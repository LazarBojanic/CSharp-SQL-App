﻿using CSharp_SQL_App.model;
using System;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CSharp_SQL_App.util {
    public static class Util {
        public static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        public static DateTime dateTimeWithoutMilliseconds(DateTime date) {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }
        public static Ugovor getUgovorFromSelectedRow(DataGridView dataGridView) {
            return new Ugovor(
                int.Parse(dataGridView.SelectedRows[0].Cells["id"].Value.ToString()),
                dataGridView.SelectedRows[0].Cells["opstina"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["nazivPlana"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["urbanista"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["tipUgovora"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["faza"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["napomena"].Value.ToString(),
                Convert.ToDateTime(dataGridView.SelectedRows[0].Cells["datumUgovora"].Value),
                dataGridView.SelectedRows[0].Cells["rokPoUgovoru"].Value.ToString(),
                Convert.ToDateTime(dataGridView.SelectedRows[0].Cells["krajnjiRok"].Value),
                int.Parse(dataGridView.SelectedRows[0].Cells["obim"].Value.ToString()),
                int.Parse(dataGridView.SelectedRows[0].Cells["prioritet"].Value.ToString()),
                Decimal.Parse(dataGridView.SelectedRows[0].Cells["cena"].Value.ToString()),
                dataGridView.SelectedRows[0].Cells["usvojen"].Value.ToString(),
                Convert.ToDateTime(dataGridView.SelectedRows[0].Cells["datumUsvajanja"].Value),
                dataGridView.SelectedRows[0].Cells["brojSluzbenogVlasnika"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["vremeRada"].Value.ToString(),
                new DateTime(1970, 1, 1),
                dataGridView.SelectedRows[0].Cells["uGuid"].Value.ToString());
        }
        public static ChangeLog getChangeLogFromSelectedRow(DataGridView dataGridView) {
            return new ChangeLog(
                int.Parse(dataGridView.SelectedRows[0].Cells["id"].Value.ToString()),
                dataGridView.SelectedRows[0].Cells["imeTabele"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["imePolja"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["tipAkcije"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["primarniKljuc"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["staraVrednost"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["novaVrednost"].Value.ToString());
        }
        public static User getUserFromSelectedRow(DataGridView dataGridView) {
            return new User(
                int.Parse(dataGridView.SelectedRows[0].Cells["id"].Value.ToString()),
                dataGridView.SelectedRows[0].Cells["username"].Value.ToString(),
                "",
                dataGridView.SelectedRows[0].Cells["privilegija"].Value.ToString());
        }
        public static UgovorFile getUgovorFileFromSelectedRow(DataGridView dataGridView) {
            return new UgovorFile(
                int.Parse(dataGridView.SelectedRows[0].Cells["id"].Value.ToString()),
                dataGridView.SelectedRows[0].Cells["fajlPutanja"].Value.ToString(),
                dataGridView.SelectedRows[0].Cells["uGuid"].Value.ToString());
        }
        public static string getUgovorCellValue(Ugovor ugovor, int index) {
            int i = 0;
            foreach (PropertyInfo propertyInfo in ugovor.GetType().GetProperties()) {
                if (propertyInfo.Name.Equals("vremeUgovora")) {
                    continue;
                }
                else {
                    if (!string.IsNullOrEmpty(propertyInfo.GetValue(ugovor).ToString())) {
                        if (i == index) {
                            return propertyInfo.GetValue(ugovor).ToString();
                        }
                    }
                    else {
                        if (i == index) {
                            return "null";
                        }
                    }
                    i++;
                }
            }
            return "null";
        }
        public static string buildClipboardUgovorString(Ugovor ugovor) {
            string clipboard = "";
            foreach (PropertyInfo propertyInfo in ugovor.GetType().GetProperties()) {
                if (!propertyInfo.Name.Equals("vremeUgovora")) {
                    if (!string.IsNullOrEmpty(propertyInfo.GetValue(ugovor).ToString())) {
                        clipboard += propertyInfo.GetValue(ugovor).ToString() + ",";
                    }
                    else {
                        clipboard += "null,";
                    }
                }
            }
            return clipboard.Trim(',');
        }
        public static string getChangeLogCellValue(ChangeLog changeLog, int index) {
            int i = 0;
            foreach (PropertyInfo propertyInfo in changeLog.GetType().GetProperties()) {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(changeLog).ToString())) {
                    if (i == index) {
                        return propertyInfo.GetValue(changeLog).ToString();
                    }
                }
                else {
                    if (i == index) {
                        return "null";
                    }
                }
                i++;
            }
            return "null";
        }
        public static string buildClipboardChangeLogString(ChangeLog changeLog) {
            string clipboard = "";
            foreach (PropertyInfo propertyInfo in changeLog.GetType().GetProperties()) {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(changeLog).ToString())) {
                    clipboard += propertyInfo.GetValue(changeLog).ToString() + ",";
                }
                else {
                    clipboard += "null,";
                }
            }
            return clipboard.Trim(',');
        }
        public static string getUserCellValue(User user, int index) {
            int i = 0;
            foreach (PropertyInfo propertyInfo in user.GetType().GetProperties()) {
                if (propertyInfo.Name.Equals("password")) {
                    continue;
                }
                else {
                    if (!string.IsNullOrEmpty(propertyInfo.GetValue(user).ToString())) {
                        if (i == index) {
                            return propertyInfo.GetValue(user).ToString();
                        }
                    }
                    else {
                        if (i == index) {
                            return "null";
                        }
                    }
                    i++;
                }
            }
            return "null";
        }
        public static string buildClipboardUserString(User user) {
            string clipboard = "";
            foreach (PropertyInfo propertyInfo in user.GetType().GetProperties()) {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(user).ToString())) {
                    clipboard += propertyInfo.GetValue(user).ToString() + ",";
                }
                else {
                    clipboard += "null,";
                }
            }
            return clipboard.Trim(',');
        }
        public static string getUgovorFileCellValue(UgovorFile ugovorFile, int index) {
            int i = 0;
            foreach (PropertyInfo propertyInfo in ugovorFile.GetType().GetProperties()) {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(ugovorFile).ToString())) {
                    if (i == index) {
                        return propertyInfo.GetValue(ugovorFile).ToString();
                    }
                }
                else {
                    if (i == index) {
                        return "null";
                    }

                    i++;
                }
            }
            return "null";
        }
        public static string buildClipboardUgovorFileString(UgovorFile ugovorFile) {
            string clipboard = "";
            foreach (PropertyInfo propertyInfo in ugovorFile.GetType().GetProperties()) {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(ugovorFile).ToString())) {
                    clipboard += propertyInfo.GetValue(ugovorFile).ToString() + ",";
                }
                else {
                    clipboard += "null,";
                }
            }
            return clipboard.Trim(',');
        }
        public static string encrypt(string clearText) {
            try {
                string encryptionKey = Properties.Resources.passwordEnryptionKey;
                byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
                using (Aes encryptor = Aes.Create()) {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream()) {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)) {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (CryptographicException) {
                MessageBox.Show("Neuspešno snimanje password-a");
            }
            return clearText;
        }
        public static string decrypt(string cipherText) {
            try {
                string encryptionKey = Properties.Resources.passwordEnryptionKey;
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create()) {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream()) {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)) {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (CryptographicException) {
                MessageBox.Show("Neuspešno učitavanje password-a");
            }
            return cipherText;
        }
    }
}