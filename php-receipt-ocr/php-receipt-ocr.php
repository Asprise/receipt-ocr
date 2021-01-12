<?php

function receiptOcr($imageFile) {
  $receiptOcrEndpoint = 'https://ocr.asprise.com:48443/api/v1/receipt'; //

  $ch = curl_init();
  curl_setopt($ch, CURLOPT_URL, $receiptOcrEndpoint);
  curl_setopt($ch, CURLOPT_POST, true);
  curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

  curl_setopt($ch, CURLOPT_POSTFIELDS, array(
  	'client_id' => 'TEST',      // Use 'TEST' for testing purpose
    'recognizer' => 'auto',     // can be 'US', 'CA', 'JP', 'SG' or 'auto'
    'ref_no' => 'ocr_php_123',  // optional caller provided ref code
    'file' => curl_file_create($imageFile) // the image file
  ));

  $result = curl_exec($ch);
  if(curl_errno($ch)){
      throw new Exception(curl_error($ch));
  }

  echo $result; // result in JSON
}

print("=== Java Receipt OCR Demo - Need help? Email support@asprise.com ===\n");
receiptOcr('receipt.jpg'); // Modify this to use your own file if necessary