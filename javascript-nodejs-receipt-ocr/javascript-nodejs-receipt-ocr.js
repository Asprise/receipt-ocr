// To run it: node javascript-nodejs-receipt-ocr.js
console.log("=== Node.js Receipt OCR Demo - Need help? Email support@asprise.com ===");

var receiptOcrEndpoint = 'https://ocr.asprise.com/api/v1/receipt';
var imageFile = 'receipt.jpg'; // Modify this to use your own file if necessary

var fs = require('fs');
var request = require('request');
request.post({
  url: receiptOcrEndpoint,
  formData: {
    client_id: 'TEST',        // Use 'TEST' for testing purpose
    recognizer: 'auto',       // can be 'US', 'CA', 'JP', 'SG' or 'auto'
    ref_no: 'ocr_nodejs_123', // optional caller provided ref code
    file: fs.createReadStream(imageFile) // the image file
  },
}, function(error, response, body) {
  if(error) {
    console.error(error);
  }
  console.log(body); // Receipt OCR result in JSON
});