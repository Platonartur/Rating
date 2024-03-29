﻿using AutoMapper;
using GirlsRanking.Girls;
using HostelGirls.Web.Models;
using HostelGirls.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HostelGirls.Web.Pages
{
    public class GirlsListBase:ComponentBase
    {
        private IEnumerable<Teen> _teens;

        protected string DisplayTime()
        {
            return $"Рейтинг на: {DateTime.Now.ToShortDateString()}";
        }
        [Inject]
        public ITeenService TeenService { get; set; }

        public IEnumerable<Teen> Teens { get { return _teens; } set { _teens = value; } }

        [Inject]
        public IMapper Mapper { get; set; }
        protected override async Task OnInitializedAsync()
        {
            
            if (_teens == null)
                _teens = (await TeenService.GetTeens()).ToList();

            if (TeensStatic.Teens == null)
                TeensStatic.Teens = (await TeenService.GetTeens()).ToList();

            //await Task.Run(LoadTeens);
        }

























        /*protected List<Teen> teens { get; set; }        
        protected async override Task OnInitializedAsync()
        {           
            teens = new List<Teen>()
        {            
            new Teen()
            {
                Id = "https://vk.com/die_young_my_baby",
                Name = "Anya Shelk",
                Img = "images/TopTelka.jpg"
            },
            new Teen()
            {
                Id = "https://vk.com/id412379471",
                Name = "Aurora Redfield",
                Img = "images/Amaliya.jpg"
            },
            new Teen()
            {
                Id = "https://vk.com/lellap",
                Name = "Elena Popovskikh",
                Img = "images/Sofia_kolotilina.jpg"
            }
        };
        }  
        */

        //    [Inject]
        //    public ITeenService TeenService { get; set; }

        //    public IEnumerable<Teen> teens { get; set; }
        //    protected override async Task OnInitializedAsync()
        //    {
        //        teens = new List<Teen>();
        //       //teens = (await TeenService.GetTeens()).ToList();
        //       //await Task.Run (LoadTeens);
        //    }
        //    //protected void LoadTeens()
        //    //{            
        //    //    teens = new List<Teen>
        //    //    {
        //    //        new Teen()
        //    //        {
        //    //            Number = 0,
        //    //            Id = "https://vk.com/id412379471",
        //    //            Name = "Aurora Redfield",
        //    //            Img = "images/Amaliya.jpg",
        //    //            ImgName = "images/Amaliya.jpg".Remove("images/Amaliya.jpg".Length-4),
        //    //            TeenId = 1
        //    //        },
        //    //        new Teen()
        //    //        {
        //    //            Number = 0,
        //    //            Id = "https://vk.com/lellap",
        //    //            Name = "Elena Popovskikh",
        //    //            Img = "images/Sofia_kolotilina.jpg",
        //    //            ImgName = "images/Sofia_kolotilina.jpg".Remove("images/Sofia_kolotilina.jpg".Length-4),
        //    //            TeenId = 2
        //    //        },
        //    //        new Teen()
        //    //        {
        //    //             Number = 0,
        //    //             Id = "https://vk.com/die_young_my_baby",
        //    //             Name = "Anya Shelk",
        //    //             Img = "images/TopTelka.jpg",
        //    //             ImgName = "images/TopTelka.jpg".Remove("images/TopTelka.jpg".Length-4),
        //    //             TeenId = 3
        //    //        },
        //    //        new Teen()
        //    //        {
        //    //            Number = 0,
        //    //            Id="https://vk.com/id327657095",
        //    //            Name="katerina Dershavina",
        //    //            Img="images/DaryaAfanasieva.jpg",
        //    //            ImgName="images/DaryaAfanasieva.jpg".Remove("images/DaryaAfanasieva.jpg".Length-4),
        //    //            TeenId = 4
        //    //        }
        //    //    };
        //    //}    

        //    private void Voting()
        //    {         
        //        //var rand = new Random();
        //        //int v = rand.Next(teens.SelectMany);
        //        //Random r = new Random();
        //        //var result1 = teens;
        //        //teens.Push(3);
        //        //for (int i = 0; i < teens.Count(); i++)
        //        //{

        //        //}
        //        //if teens.Contains(){ }
        //        //var randomNumbers = result1.Select(r);
        //        //foreach(var teen in teens)
        //        //{
        //        //    if (teen.Number = rand.NextBytes())
        //        //    {

        //        //    }
        //        //    var random = new Random();
        //        //    teen.Number = random.OrderBy(order => random.Next);
        //        //}
        //        //foreach (int i in Enumerable.Range(0, 9).OrderBy(teens => r.Next()))
        //        //{
        //        //    Console.WriteLine(teens); 
        //        //}

        //    }
        //}
        //public class ForVoting
        //{

    }
}
