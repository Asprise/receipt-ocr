import java.io.File;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.mime.MultipartEntityBuilder;
import org.apache.http.entity.mime.content.FileBody;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;

/**
 * Uploads an image for receipt OCR and gets the result in JSON.
 * Required dependencies: org.apache.httpcomponents:httpclient:4.5.13 and org.apache.httpcomponents:httpmime:4.5.13
 */
public class JavaReceiptOcr {

	public static void main(String[] args) throws Exception {
		String receiptOcrEndpoint = "https://ocr.asprise.com:48443/v1/receipt"; // Receipt OCR API endpoint
		File imageFile = new File("receipt.jpg");

		System.out.println("=== Java Receipt OCR Demo - Need help? Email support@asprise.com ===");

		try (CloseableHttpClient client = HttpClients.createDefault()) {
			HttpPost post = new HttpPost(receiptOcrEndpoint);
			post.setEntity(MultipartEntityBuilder.create()
				.addTextBody("client_id", "TEST")       // Use 'TEST' for testing purpose
				.addTextBody("recognizer", "all")       // can be 'US', 'CA', 'JP', 'SG' or 'all'
				.addTextBody("ref_no", "ocr_java_123'") // optional caller provided ref code
				.addPart("file", new FileBody(imageFile))    // the image file
				.build());

			try (CloseableHttpResponse response = client.execute(post)) {
				System.out.println(EntityUtils.toString(response.getEntity())); // Receipt OCR result in JSON
			}
		}
	}
}
