namespace TestApi.DTOs.BannedWord
{
    public class BannedWordCreateDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int WordId { get; set; }
    }
}
