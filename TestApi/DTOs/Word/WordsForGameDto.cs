namespace TestApi.DTOs.Word
{
    public class WordsForGameDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> BannedWord { get; set; }


    }
}
