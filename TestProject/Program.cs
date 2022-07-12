﻿namespace TestProject;

class Program
{
    public static byte Color;
    
    public static void Main(string[] args)
    {
        Cycle('A');
        for (;;);

        void Cycle(char c)
        {
            unsafe
            {
                // Cycle through all foreground colors, starting from the last one
                var start = (byte)c;
                var index = 0;
                var address = 0xB8000;
                for (var i = 0; i < 16; i++)
                {
                    *(byte*)(address + index++) = start++;
                    *(byte*)(address + index++) = Color++;
                }
            }
        }
    }
}