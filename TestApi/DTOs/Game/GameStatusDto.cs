﻿using TestApi.DTOs.Word;
using TestApi.Entities;

namespace TestApi.DTOs.Game
{
    public class GameStatusDto
    {
        public byte Success { get; set; }
        public byte Fail { get; set; }
        public byte Skip { get; set; }
        public Stack<WordsForGameDto> Words { get; set; }
        public int[] UsedWordIds { get; set; }  


    }
}
