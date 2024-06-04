using ClosedXML.Excel;
using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLyKhachHangNganHang.DAO
{
    public class ExcelExporter
    {
        public void ExportTransactionHistoryToExcel(List<TransactionHistory> transactions, string filePath)
        {
            // Tạo một bảng Excel mới
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Transaction History");

            // Tạo các cột trong bảng Excel
            worksheet.Cell(1, 1).Value = "Transaction ID";
            worksheet.Cell(1, 2).Value = "Account ID";
            worksheet.Cell(1, 3).Value = "Service ID";
            worksheet.Cell(1, 4).Value = "Transaction Date";
            worksheet.Cell(1, 5).Value = "Transaction Amount";
            worksheet.Cell(1, 6).Value = "Transaction Description";

            // Đổ dữ liệu từ danh sách giao dịch vào bảng Excel
            int row = 2;
            foreach (var transaction in transactions)
            {
                worksheet.Cell(row, 1).Value = transaction.TransactionID;
                worksheet.Cell(row, 2).Value = transaction.AccountID;
                worksheet.Cell(row, 3).Value = transaction.ServiceID;
                worksheet.Cell(row, 4).Value = transaction.TransactionDate;
                worksheet.Cell(row, 5).Value = transaction.TransactionAmount;
                worksheet.Cell(row, 6).Value = transaction.TransactionDescription;
                row++;
            }

            // Lưu bảng Excel vào file
            workbook.SaveAs(filePath);
        }
    }
}
