# Receipt OCR in C# VB.NET, Java, JavaScript, PHP & Python

Instantly detects, extracts, recognizes and enriches all text and data on receipts
through OCR using sJavaScript/Node.Js, Java, C# VB.NET, PHP, Python & Ruby.

[📖 Read developers' guide here](http://asprise.com/ocr/api/docs/html/receipt-ocr.html)

[🧾 OCR your own receipts without coding](http://asprise.com/receipt-ocr-data-capture-api/extract-text-reader-scanner-index.html)

### Sample 1

[✨ View the complete demos here](http://asprise.com/ocr/api/docs/html/receipt-ocr.html)


#### Input image

<table>
<tr>
<td valign="top">
<a href="https://github.com/Asprise/receipt-ocr/blob/main/receipt.jpg" target="_blank">
<img src="https://github.com/Asprise/receipt-ocr/blob/main/receipt.jpg" height="300" alt="Receipt OCR demo">
</a>
</td>

<td>OCR Text:
<pre>     McDonald's Toa Payoh Central
           600 @ Toa Payoh #01-02,
              Singapore 319515
                Tel: 62596362
       McDonald's Restaurants Pte Ltd
          GST REGN NO: M2-0023981-4
                 TAX INVOICE
  INV. 002201330026
  ORD # 57 -REG #1- 13/01/2016 15:49:52
  QTY ITEM                           TOTAL
    1 Med Ice Lemon Tea               2.95
    1 Coffee with Milk                2.40
 Eat-In Total (incl GST)              5.35
 Cash Tendered                        10.00
 Change                                4.65
 TOTAL INCLUDES GST OF                 0.35
     Thank You and Have A Nice Day</pre>
</td>
</tr>
</table>

#### Full Output JSON

```javascript
{
  "request_id" : "P_218.186.139.27_kjnq6lpu_zbe",
  "ref_no" : "AspDemo_1610076841490_738",
  "file_name" : "SG-01.jpg",
  "request_received_on" : 1610076846450,
  "success" : true,
  "recognition_completed_on" : 1610076848572,
  "receipts" : [ {
    "merchant_name" : "McDonald's",
    "merchant_address" : "600 @ Toa Payoh #01-02, Singapore 319515",
    "merchant_phone" : "62596362",
    "merchant_website" : null,
    "merchant_tax_reg_no" : "M2-0023981-4",
    "merchant_company_reg_no" : null,
    "region" : null,
    "mall" : "600 @ Toa Payoh",
    "country" : "SG",
    "receipt_no" : "002201330026",
    "date" : "2016-01-13",
    "time" : "15:49",
    "items" : [ {
      "amount" : 2.95,
      "description" : "Med Ice Lemon Tea",
      "flags" : "",
      "qty" : 1,
      "remarks" : null,
      "unitPrice" : null
    }, {
      "amount" : 2.40,
      "description" : "Coffee with Milk",
      "flags" : "",
      "qty" : 1,
      "remarks" : null,
      "unitPrice" : null
    } ],
    "currency" : "SGD",
    "total" : 5.35,
    "subtotal" : null,
    "tax" : 0.35,
    "service_charge" : null,
    "tip" : null,
    "payment_method" : "cash",
    "payment_details" : null,
    "credit_card_type" : null,
    "credit_card_number" : null,
    "ocr_text" : "         McDonald's Toa Payoh Central\n           600 @ Toa Payoh #01-02,\n              Singapore 319515\n                Tel: 62596362\n       McDonald's Restaurants Pte Ltd\n          GST REGN NO: M2-0023981-4\n                 TAX INVOICE\n  INV. 002201330026\n  ORD # 57 -REG #1- 13/01/2016 15:49:52\n  QTY ITEM                           TOTAL\n    1 Med Ice Lemon Tea               2.95\n    1 Coffee with Milk                2.40\n Eat-In Total (incl GST)              5.35\n Cash Tendered                        10.00\n Change                                4.65\n TOTAL INCLUDES GST OF                 0.35\n     Thank You and Have A Nice Day",
    "ocr_confidence" : 96.82,
    "width" : 1940,
    "height" : 2395,
    "avg_char_width" : null,
    "avg_line_height" : null
  } ]
}
```


### Sample 2 - two receipts on one image

#### Input image

<table>
<tr>
<td>
<a href="http://asprise.com/ocr/api/img/demo/SG-20.jpg" target="_blank">
<img src="http://asprise.com/ocr/api/img/demo/SG-20.jpg" height="300" alt="Two receipts on one image">
</a>
</td>
OCR Text:
<pre>                            • SINGAPORE
      * Takashimaya:
                    Together dreamie
                                      come true
             Takashimaya Singapore Limited
          391A Orchard Road Singapore 238873
                     Tel: 67381111
          GST Reg# M2-0087370-0 TAX INVOICE
      TSC                              TAX INVOICE
      GST Reg #                       M2-0087370-0
      Company Reg #                      198902636N
      Sale                  11156 0001 11041 98604
                                  17/10/2020 14:11
      00056010 Decorte SB
                       1@101.00            101.00
            SLBTOTAL-ALL                   101.00
            DISCOUNTABLE                   101.00
            Store Wide 10 %                10.10
            SUBTOTAL                        90.90
            TOTAL                           90.90
            1 Items GST-7% (Incl)            5.95
       TKAmex                               90.90
         3779 XXXX XXX5 797 XX /XX 727228
       CARD ID 91
       Cashier Name:Candy Chee
       BP Award ID : 3779 XXXX XXX5 797
       Customer Name:
       Point Before Update                      172
       Bonus Points Credited                     18
       Total Bonus Points                       190
      Bonus Points Expiry (MM /YY) 12/24
          Takashimaya Bonus Points will expire
                with the card expiry date
                        1104198504
              Company Reg. No : 198902636N
         Goods Exchange/refund must be within
        7 days in good condition with receipt.
      Credi: voucher will be issued for refund
      -------------- 
        KINOKUNIYA BOOKSTORES (S) PTE LTD
                  391 ORCHARD ROAD
                    #04-20A-C / 21
      Takashi maya S.C., Ngee Ann City
         TEL :67375021 GST REG :M2-0052652-0
            BUSINESS REG . NO : 198301413H
      Slip: 0000000303000065419
      Staff: Alena Huang Trans:            69403
      Date: 17/10/20 2:28
      Description                     Aunount
      Barcode: 2111471837465           11.82
      Grammar for Secondar
      Barcode: 2131471859984           14.45
      The Illustrated Firs
      Total $                         26.27
      Credit Card                     -26.27
       off Us Visa
        7077
      Number of items:                    2
         GST %   Net. Amt       GST      Amount
            7      24.55       1.72      26.27
            THANK YOU FOR SHOPPING WITH
               KINOKUNTYA BOOKSTORES
           SINGAPORE MAIN STORE, LEVEL 4
                    *T0303000069403</pre>
<td>
</td>
</tr></table>

#### Output JSON

```javascript
{
  "request_id" : "P_218.186.139.27_kjnqc46o_51g",
  "ref_no" : "AspDemo_1610077100573_184",
  "file_name" : "SG-20.jpg",
  "request_received_on" : 1610077103664,
  "success" : true,
  "recognition_completed_on" : 1610077104172,
  "receipts" : [ {
    "merchant_name" : "Takashimaya",
    "merchant_address" : "391A Orchard Road Singapore 238873",
    "merchant_phone" : "67381111",
    "merchant_website" : null,
    "merchant_tax_reg_no" : "M2-0087370-0",
    "merchant_company_reg_no" : "198902636N",
    "region" : null,
    "mall" : null,
    "country" : "SG",
    "receipt_no" : "11156 0001 11041 98604",
    "date" : "2020-10-17",
    "time" : "14:11",
    "items" : [ {
      "amount" : 101.00,
      "description" : "00056010 Decorte SB",
      "flags" : "",
      "qty" : 1,
      "remarks" : null,
      "unitPrice" : 101.00
    } ],
    "currency" : "SGD",
    "total" : 90.90,
    "subtotal" : 90.90,
    "tax" : -87370.0,
    "service_charge" : null,
    "tip" : null,
    "payment_method" : "credit_card",
    "payment_details" : null,
    "credit_card_type" : "amex",
    "credit_card_number" : null,
    "ocr_text" : "                            • SINGAPORE\n * Takashimaya:\n               Together dreamie\n                                 come true\n        Takashimaya Singapore Limited\n     391A Orchard Road Singapore 238873\n                Tel: 67381111\n     GST Reg# M2-0087370-0 TAX INVOICE\n TSC                              TAX INVOICE\n GST Reg #                       M2-0087370-0\n Company Reg #                      198902636N\n Sale                  11156 0001 11041 98604\n                             17/10/2020 14:11\n 00056010 Decorte SB\n                  1@101.00            101.00\n       SLBTOTAL-ALL                   101.00\n       DISCOUNTABLE                   101.00\n       Store Wide 10 %                10.10\n       SUBTOTAL                        90.90\n       TOTAL                           90.90\n       1 Items GST-7% (Incl)            5.95\n  TKAmex                               90.90\n    3779 XXXX XXX5 797 XX /XX 727228\n  CARD ID 91\n  Cashier Name:Candy Chee\n  BP Award ID : 3779 XXXX XXX5 797\n  Customer Name:\n  Point Before Update                      172\n  Bonus Points Credited                     18\n  Total Bonus Points                       190\n Bonus Points Expiry (MM /YY) 12/24\n     Takashimaya Bonus Points will expire\n           with the card expiry date\n                   1104198504\n         Company Reg. No : 198902636N\n    Goods Exchange/refund must be within\n   7 days in good condition with receipt.\n Credi: voucher will be issued for refund",
    "ocr_confidence" : 94.79,
    "width" : 328,
    "height" : 821,
    "avg_char_width" : null,
    "avg_line_height" : null
  }, {
    "merchant_name" : "KINOKUNIYA BOOKSTORES (S) PTE LTD",
    "merchant_address" : "391 ORCHARD ROAD, #04-20A-C / 21",
    "merchant_phone" : "67375021",
    "merchant_website" : null,
    "merchant_tax_reg_no" : "M2-0052652-0",
    "merchant_company_reg_no" : "198301413H",
    "region" : null,
    "mall" : null,
    "country" : "SG",
    "receipt_no" : "69403",
    "date" : "2020-10-17",
    "time" : "02:28",
    "items" : [ {
      "amount" : 11.82,
      "description" : "Barcode: 2111471837465",
      "flags" : "",
      "qty" : null,
      "remarks" : null,
      "unitPrice" : null
    }, {
      "amount" : 14.45,
      "description" : "Barcode: 2131471859984",
      "flags" : "",
      "qty" : null,
      "remarks" : null,
      "unitPrice" : null
    } ],
    "currency" : "SGD",
    "total" : 26.27,
    "subtotal" : null,
    "tax" : null,
    "service_charge" : null,
    "tip" : null,
    "payment_method" : null,
    "payment_details" : null,
    "credit_card_type" : null,
    "credit_card_number" : null,
    "ocr_text" : "   KINOKUNIYA BOOKSTORES (S) PTE LTD\n             391 ORCHARD ROAD\n               #04-20A-C / 21\n Takashi maya S.C., Ngee Ann City\n    TEL :67375021 GST REG :M2-0052652-0\n       BUSINESS REG . NO : 198301413H\n Slip: 0000000303000065419\n Staff: Alena Huang Trans:            69403\n Date: 17/10/20 2:28\n Description                     Aunount\n Barcode: 2111471837465           11.82\n Grammar for Secondar\n Barcode: 2131471859984           14.45\n The Illustrated Firs\n Total $                         26.27\n Credit Card                     -26.27\n  off Us Visa\n   7077\n Number of items:                    2\n    GST %   Net. Amt       GST      Amount\n       7      24.55       1.72      26.27\n       THANK YOU FOR SHOPPING WITH\n          KINOKUNTYA BOOKSTORES\n      SINGAPORE MAIN STORE, LEVEL 4\n               *T0303000069403",
    "ocr_confidence" : 95.63,
    "width" : 344,
    "height" : 676,
    "avg_char_width" : null,
    "avg_line_height" : null
  } ]
}
```

### Next

[📖 Read developers' guide here](http://asprise.com/ocr/api/docs/html/receipt-ocr.html)

[🧾 OCR your own receipts without coding](http://asprise.com/receipt-ocr-data-capture-api/extract-text-reader-scanner-index.html)
