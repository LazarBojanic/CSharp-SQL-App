﻿using CSharp_SQL_App.util;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSharp_SQL_App.model {
    public class Ugovor {
        public int id { get; set; }
        public string opstina { get; set; }
        public string nazivPlana { get; set; }
        public string urbanista { get; set; }
        public string tipUgovora { get; set; }
        public string faza { get; set; }
        public string napomena { get; set; }
        public DateTime datumUgovora { get; set; }
        public string rokPoUgovoru { get; set; }
        public DateTime krajnjiRok { get; set; }
        public int obim { get; set; }
        public int prioritet { get; set; }
        public decimal cena { get; set; }
        public string usvojen { get; set; }
        public DateTime datumUsvajanja { get; set; }
        public string brojSluzbenogVlasnika { get; set; }
        public string vremeRada { get; set; }
        public DateTime vremeUgovora { get; set; }
        public string uGuid { get; set; }
        public Ugovor(int id, string opstina, string nazivPlana, string urbanista, string faza, string tipUgovora,
            string napomena, DateTime datumUgovora, string rokPoUgovoru, DateTime krajnjiRok, int obim,
            int prioritet, decimal cena, string usvojen, DateTime datumUsvajanja, string brojSluzbenogVlasnika, string vremeRada,
            DateTime vremeUgovora, string uGuid) {
            this.id = id;
            this.opstina = opstina;
            this.nazivPlana = nazivPlana;
            this.urbanista = urbanista;
            this.tipUgovora = tipUgovora;
            this.faza = faza;
            this.napomena = napomena;
            this.datumUgovora = datumUgovora;
            this.rokPoUgovoru = rokPoUgovoru;
            this.krajnjiRok = krajnjiRok;
            this.obim = obim;
            this.prioritet = prioritet;
            this.cena = cena;
            this.usvojen = usvojen;
            this.datumUsvajanja = datumUsvajanja;
            this.brojSluzbenogVlasnika = brojSluzbenogVlasnika;
            this.vremeRada = vremeRada;
            this.vremeUgovora = vremeUgovora;
            this.uGuid = uGuid;
        }
        public Ugovor() {
            this.id = 0;
            this.opstina = "";
            this.nazivPlana = "";
            this.urbanista = "";
            this.tipUgovora = "";
            this.faza = "";
            this.napomena = "";
            this.datumUgovora = DateTime.Today;
            this.rokPoUgovoru = "";
            this.krajnjiRok = DateTime.Today;
            this.obim = 0;
            this.prioritet = 0;
            this.cena = 0;
            this.usvojen = "Ne";
            this.datumUsvajanja = new DateTime(1970, 1, 1);
            this.brojSluzbenogVlasnika = "";
            this.vremeRada = "";
            this.vremeUgovora = DateTime.Now;
            this.uGuid = Guid.NewGuid().ToString();
        }
        public bool loadFromDatabase(int parId) {
            OleDbConnection connection = Util.GetConnection();
            connection.Open();
            string query = "SELECT * FROM ugovor WHERE id = @id";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", parId);
            OleDbDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows) {
                dataReader.Read();
                try {
                    id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        id = 0;
                    }
                }
                try {
                    opstina = dataReader.GetString(dataReader.GetOrdinal("opstina"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        opstina = "";
                    }
                }
                try {
                    nazivPlana = dataReader.GetString(dataReader.GetOrdinal("nazivPlana"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        nazivPlana = "";
                    }
                }
                try {
                    urbanista = dataReader.GetString(dataReader.GetOrdinal("urbanista"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        urbanista = "";
                    }
                }
                try {
                    tipUgovora = dataReader.GetString(dataReader.GetOrdinal("tipUgovora"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        tipUgovora = "";
                    }
                }
                try {
                    faza = dataReader.GetString(dataReader.GetOrdinal("faza"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        faza = "";
                    }
                }
                try {
                    napomena = dataReader.GetString(dataReader.GetOrdinal("napomena"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        napomena = "";
                    }
                }
                try {
                    datumUgovora = dataReader.GetDateTime(dataReader.GetOrdinal("datumUgovora"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        datumUgovora = DateTime.Today;
                    }
                }
                try {
                    rokPoUgovoru = dataReader.GetString(dataReader.GetOrdinal("rokPoUgovoru"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        rokPoUgovoru = "";
                    }
                }
                try {
                    krajnjiRok = dataReader.GetDateTime(dataReader.GetOrdinal("krajnjiRok"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        krajnjiRok = DateTime.Today;
                    }
                }
                try {
                    obim = dataReader.GetInt32(dataReader.GetOrdinal("obim"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        obim = 0;
                    }
                }

                try {
                    prioritet = dataReader.GetInt32(dataReader.GetOrdinal("prioritet"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        prioritet = 0;
                    }
                }
                try {
                    cena = dataReader.GetDecimal(dataReader.GetOrdinal("cena"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        cena = 0;
                    }
                }
                try {
                    if (dataReader.GetString(dataReader.GetOrdinal("usvojen")).Equals("Da")) {
                        usvojen = "Da";
                    }
                    else {
                        usvojen = "Ne";
                    }
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        usvojen = "Ne";
                    }
                }
                try {
                    datumUsvajanja = dataReader.GetDateTime(dataReader.GetOrdinal("datumUsvajanja"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        datumUsvajanja = new DateTime(1970, 1, 1);
                    }
                }
                try {
                    brojSluzbenogVlasnika = dataReader.GetString(dataReader.GetOrdinal("brojSluzbenogVlasnika"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        brojSluzbenogVlasnika = "";
                    }
                }
                try {
                    vremeRada = dataReader.GetString(dataReader.GetOrdinal("vremeRada"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        vremeRada = "";
                    }
                }
                try {
                    vremeUgovora = dataReader.GetDateTime(dataReader.GetOrdinal("vremeUgovora"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        vremeUgovora = DateTime.Now;
                    }
                }
                try {
                    uGuid = dataReader.GetString(dataReader.GetOrdinal("uGuid"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        uGuid = "";
                    }
                }
                connection.Close();
                return true;
            }
            else {
                MessageBox.Show("Ne postoji id", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
        }
        public void saveToDatabase() {
            OleDbConnection connection = Util.GetConnection();
            connection.Open();
            vremeUgovora = DateTime.Now;
            try {
                if (id == 0) {
                    string query = "INSERT INTO ugovor (opstina, nazivPlana, urbanista, tipUgovora, faza, napomena, datumUgovora," +
                        " rokPoUgovoru, obim, krajnjiRok, prioritet, cena, usvojen, datumUsvajanja, brojSluzbenogVlasnika, vremeRada, vremeUgovora, uGuid) VALUES" +
                        " (@opstina, @nazivPlana, @urbanista, @tipUgovora, @faza, @napomena, @datumUgovora, @rokPoUgovoru, @obim, @krajnjiRok," +
                        " @prioritet, @cena, @usvojen, @datumUsvajanja, @brojSluzbenogVlasnika, @vremeRada, @vremeUgovora, @uGuid)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@opstina", opstina);
                    command.Parameters.AddWithValue("@nazivPlana", nazivPlana);
                    command.Parameters.AddWithValue("@urbanista", urbanista);
                    command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                    command.Parameters.AddWithValue("@faza", faza);
                    command.Parameters.AddWithValue("@napomena", napomena);
                    command.Parameters.AddWithValue("@datumUgovora", datumUgovora);
                    command.Parameters.AddWithValue("@rokPoUgovoru", rokPoUgovoru);
                    command.Parameters.AddWithValue("@obim", obim);
                    command.Parameters.AddWithValue("@krajnjiRok", krajnjiRok);
                    command.Parameters.AddWithValue("@prioritet", prioritet);
                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@usvojen", usvojen);
                    command.Parameters.AddWithValue("@datumUsvajanja", datumUsvajanja);
                    command.Parameters.AddWithValue("@brojSluzbenogVlasnika", brojSluzbenogVlasnika);
                    command.Parameters.AddWithValue("@vremeRada", vremeRada);
                    command.Parameters.Add("@vremeUgovora", OleDbType.DBTimeStamp).Value = Util.dateTimeWithoutMilliseconds(vremeUgovora);
                    command.Parameters.AddWithValue("@uGuid", uGuid);
                    int recordsAffected = command.ExecuteNonQuery();
                }
                else {
                    string query = "UPDATE ugovor SET opstina = @opstina, nazivPlana = @nazivPlana, urbanista = @urbanista, tipUgovora = @tipUgovora," +
                        " faza = @faza, napomena = @napomena, datumUgovora = @datumUgovora, rokPoUgovoru = @rokPoUgovoru, obim = @obim," +
                        " krajnjiRok = @krajnjiRok, prioritet = @prioritet, cena = @cena, usvojen = @usvojen, datumUsvajanja = @datumUsvajanja," +
                        " brojSluzbenogVlasnika = @brojSluzbenogVlasnika, vremeRada = @vremeRada, vremeUgovora = @vremeUgovora WHERE id = @id";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@opstina", opstina);
                    command.Parameters.AddWithValue("@nazivPlana", nazivPlana);
                    command.Parameters.AddWithValue("@urbanista", urbanista);
                    command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                    command.Parameters.AddWithValue("@faza", faza);
                    command.Parameters.AddWithValue("@napomena", napomena);
                    command.Parameters.AddWithValue("@datumUgovora", datumUgovora);
                    command.Parameters.AddWithValue("@rokPoUgovoru", rokPoUgovoru);
                    command.Parameters.AddWithValue("@obim", obim);
                    command.Parameters.AddWithValue("@krajnjiRok", krajnjiRok);
                    command.Parameters.AddWithValue("@prioritet", prioritet);
                    command.Parameters.AddWithValue("@cena", cena);
                    command.Parameters.AddWithValue("@usvojen", usvojen);
                    command.Parameters.AddWithValue("@datumUsvajanja", datumUsvajanja);
                    command.Parameters.AddWithValue("@brojSluzbenogVlasnika", brojSluzbenogVlasnika);
                    command.Parameters.AddWithValue("@vremeRada", vremeRada);
                    command.Parameters.Add("@vremeUgovora", OleDbType.DBTimeStamp).Value = Util.dateTimeWithoutMilliseconds(vremeUgovora);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}