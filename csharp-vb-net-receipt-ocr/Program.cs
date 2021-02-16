using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace csharp_vb_net_receipt_ocr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# VB.NET Receipt OCR Demo - Need help? Email support@asprise.com ===");
            string response = httpPost("https://ocr.asprise.com/api/v1/receipt", // Receipt OCR API endpoint
                new NameValueCollection()
                {
                    {"client_id", "TEST"}, // Use 'TEST' for testing purpose
                    {"recognizer", "auto"}, // can be 'US', 'CA', 'JP', 'SG' or 'auto'
                    {"ref_no", "ocr_dot_net_123"} // optional caller provided ref code
                },
                new NameValueCollection() {{"file", "../../receipt.jpg"}} // Modify this to use your own file if necessary
            );
            Console.WriteLine(response); // Result in JSON

            Console.WriteLine("\n-- Press ENTER to exit --\n");
            Console.ReadLine();
        }

        private static string httpPost(string url, NameValueCollection values, NameValueCollection files = null)
        {
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            // The first boundary
            byte[] boundaryBytes = System.Text.Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            // The last boundary
            byte[] trailer = System.Text.Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
            // The first time it itereates, we need to make sure it doesn't put too many new paragraphs down or it completely messes up poor webbrick
            byte[] boundaryBytesF = System.Text.Encoding.ASCII.GetBytes("--" + boundary + "\r\n");

            // Create the request and set parameters
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = true;
            request.Credentials = System.Net.CredentialCache.DefaultCredentials;

            // Get request stream
            Stream requestStream = request.GetRequestStream();

            foreach (string key in values.Keys)
            {
                // Write item to stream
                byte[] formItemBytes = System.Text.Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}", key, values[key]));
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                requestStream.Write(formItemBytes, 0, formItemBytes.Length);
            }

            if (files != null)
            {
                foreach (string key in files.Keys)
                {
                    string filePath = files[key];
                    if (File.Exists(filePath))
                    {
                        int bytesRead = 0;
                        byte[] buffer = new byte[2048];
                        byte[] formItemBytes = System.Text.Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n", key, files[key]));
                        requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                        requestStream.Write(formItemBytes, 0, formItemBytes.Length);

                        using (FileStream fileStream = new FileStream(files[key], FileMode.Open, FileAccess.Read))
                        {
                            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                // Write file content to stream, byte by byte
                                requestStream.Write(buffer, 0, bytesRead);
                            }

                            fileStream.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found: " + filePath);
                        Console.WriteLine("Please use absolute path.");
                    }
                }
            }

            // Write trailer and close stream
            requestStream.Write(trailer, 0, trailer.Length);
            requestStream.Close();

            WebException lastWebException = null;
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException we)
            {
                response = we.Response as HttpWebResponse;
                lastWebException = we;
            }

            if (response == null)
            {
                throw lastWebException;
            } else {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
