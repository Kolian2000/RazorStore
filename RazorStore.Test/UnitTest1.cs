﻿using System.Collections.Generic;
using RazorStore.Model;
using RazorStore.Services;

namespace RazorStore.Test;

public class UnitTest1
{
    [Fact]
    public void Test_SerchAlgorithm()
    {

        
        var goods = new List<Goods>
        {
            new Goods { Name = "stasik" },
            new Goods { Name = "staska" },
            new Goods { Name = "stassi" },
            new Goods { Name = "stasko" },
            new Goods { Name = "staszz" },
            new Goods { Name = "stasss" },
            new Goods { Name = "stsdfds" },
            new Goods { Name = "stassss" },
            new Goods { Name = "stassis" },


        };
        var expected =new List<Goods>
        {
            new Goods { Name = "stasik" },
            new Goods { Name = "staska" },
            new Goods { Name = "stassi" },
            new Goods { Name = "stasko" },
            new Goods { Name = "staszz" },
            
           


        };
        var searchWords = "stasik";
        var algorithm = new SearchAlgorithm();
        var actual = algorithm.Search(searchWords, goods);
        Assert.Equal(expected, actual);

    }   
}
