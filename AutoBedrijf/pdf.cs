using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    internal class pdf
    {
        public static void CreatePDF(int klantid, string email, int invoiceID)
        {
            try
            {
                // Create a new PDF document
                Document document = new Document();

                // Get the required database classes
                userDatabase udb = new userDatabase();
                Orderdatabase odb = new Orderdatabase();

                User user = udb.getUserInfo(email);
                Order order = odb.getOrderByID(invoiceID);

                // select the file where it needs to be outputted
                string outputfile = $"./facturen/factuur_{invoiceID}.pdf";

                using (FileStream fs = new FileStream(outputfile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();
                    string htmlContent = @"<html>
<head>
    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }
        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }
        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>
</head>
<body>" +
    $"    <h2>Factuur_{invoiceID}</h2>" + @"
    <p>Bedankt voor uw bestelling</p>
    <p>In de tabel hieronder zal u alle producten vinden die u heeft besteld</p>" +
    $"<p>{user.name}</p>" +
    $"<p>{user.address}</p>" +
    $"<p>{user.email}</p>" + @"
    <table>
        <tr>
            <th>Naam</th>
            <th>Prijs</th>
            <th>Aantal</th>
            <th>Totale Prijs</th>
        </tr>";

                    if (order.productstring.Contains(';'))
                    {
                        string[] products = order.productstring.Split(';');
                        string[] amounts = order.amountString.Split(';');

                        for (int i = 0; i < products.Length; i++)
                        {                    
                            htmlContent += $"<tr><td>{products[i]}</td><td>{amounts[i]}</td></tr>";
                        }
                    } else
                    {
                        htmlContent += $"<tr><td>{order.productstring}</td><td>{order.amountString}</td></tr>";
                    }

                    htmlContent += $"<tr><th>Totaalprijs</th><td></td><td></td><th>€{order.totalPrice}</th></tr>" +
                        "</table></body></html>" +
                        "<p>Betaal deze factuur binnen 14 dagen.</p>";

                    using (StringReader sr = new StringReader(htmlContent))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                    }
                    document.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void OpenPDF(int invoiceID)
        {
            string bestellingPdf = $"./facturen/factuur_{invoiceID}.pdf";
            System.Diagnostics.Process.Start(bestellingPdf);
        }
    }
}
