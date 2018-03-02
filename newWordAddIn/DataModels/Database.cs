using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Mapping;
using MySql.Data.MySqlClient;

namespace newWordAddIn.DataModels
{
    // https://github.com/linq2db/linq2db
    // https://linq2db.github.io/articles/FAQ.html

    public class MarjieiDb : LinqToDB.Data.DataConnection
    {
        private static MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Database = "mg-marjieidb",
            UserID = "root",
            Password = "",
        };
        public MarjieiDb() : base("MySql", sb.ToString()) { }

        public ITable<Book> Books => GetTable<Book>();
        public ITable<Citation> Citations => GetTable<Citation>();
        public ITable<ConferenceProceeding> ConferenceProceedings => GetTable<ConferenceProceeding>();
        public ITable<JournalArticle> JournalArticles => GetTable<JournalArticle>();
        public ITable<MagazineArticle> MagazineArticles => GetTable<MagazineArticle>();
        public ITable<WebPage> WebPages => GetTable<WebPage>();
        public ITable<ReferenceDocument> ReferenceDocuments => GetTable<ReferenceDocument>();
    }

    [Table(Name = "citation")]
    public class Citation
    {
        [PrimaryKey, Identity, Column(Name = "wordFileID")]
        public int WordFileId { get; set; }

        [Column(Name = "citationIndex")]
        public int CitationIndex { get; set; }

        [Column(Name = "style", Length = 5), NotNull]
        public string Style { get; set; }

        public Citation()
        {
            Style = "IEEE";
        }
    }

    [Table(Name = "book")]
    public class Book
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "documentId"), Nullable]
        public int DocumentId { get; set; }

        [Column(Name = "edition", Length = 5), Nullable]
        public string Edition { get; set; }
    }

    [Table(Name = "conferenceproceeding")]
    public class ConferenceProceeding
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "documentId"), Nullable]
        public int DocumentId { get; set; }

        [Column(Name = "conferenceName", Length = 100), Nullable]
        public string ConferenceName { get; set; }

        [Column(Name = "place", Length = 50), Nullable]
        public string Place { get; set; }
    }


    [Table(Name = "journalarticle")]
    public class JournalArticle
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "documentId"), Nullable]
        public int DocumentId { get; set; }

        [Column(Name = "journalName", Length = 100), Nullable]
        public string JournalName { get; set; }

        [Column(Name = "volume", Length = 5), Nullable]
        public string Volume { get; set; }
    }


    [Table(Name = "magazinearticle")]
    public class MagazineArticle
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "documentId"), Nullable]
        public int DocumentId { get; set; }

        [Column(Name = "magazineName", Length = 100), Nullable]
        public string MagazineName { get; set; }

        [Column(Name = "month", Length = 10), Nullable]
        public string Month { get; set; }
    }


    [Table(Name = "webpage")]
    public class WebPage
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "documentId"), Nullable]
        public int DocumentId { get; set; }

        [Column(Name = "url", Length = 200), Nullable]
        public string Url { get; set; }

        [Column(Name = "AccessDate", Length = 15), Nullable]
        public string AccessDate { get; set; }
    }


    [Table(Name = "referencedocument")]
    public class ReferenceDocument
    {
        [PrimaryKey, Identity, Column(Name = "documentId")]
        public int DocumentId { get; set; }

        [Column(Name = "documentType")]
        public string DocumentType { get; set; }

        [Column(Name = "title", Length = 100), Nullable]
        public string Title { get; set; }

        [Column(Name = "author", Length = 100), Nullable]
        public string Author { get; set; }

        [Column(Name = "pages", Length = 10), Nullable]
        public string Pages { get; set; }

        [Column(Name = "publisher", Length = 100), Nullable]
        public string Publisher { get; set; }

        [Column(Name = "publishYear", Length = 10), Nullable]
        public string PublishYear { get; set; }

        [Column(Name = "referenceFile", DataType = DataType.Blob), Nullable]
        public byte[] ReferenceFile { get; set; }

        public string LongDescription => $"Author: {Author}\nPages: {Pages}\nPublished: {PublishYear}/{Publisher}";
    }

    public enum DocumentType
    {
        Book,
        ConferenceProceeding,
        JournalArticle,
        MagazineArticle,
        WebPage
    }
}
