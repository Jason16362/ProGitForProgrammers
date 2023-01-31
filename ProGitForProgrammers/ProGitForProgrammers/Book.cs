class Book
{
    public string Title { get; set; }

    public List<string> Author { get; set; }

    public DateTime PublicationDate { get; set; }

    string CreateBook()
    {
        return "book";
    }
}