using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CalculateControler
    {
        private readonly ICalculateService _Service;

        public CalculateControler()
        {
            _Service = new CalculateService();
        }


        public void MuliplyArratItems() => Console.WriteLine(_Service.MultiplyArryItems(GetArr()));
        //{
        //int[] arr = { 1, 2, 3, 4, 5, 6, };

        //ICalculateService calculateService = new CalculateService();

        //var result = calculateService.MultiplyArryItems(arr);

        //var result = _Service.MultiplyArryItems(arr);


        //Console.WriteLine(_Service.MultiplyArryItems(arr));

        //var result = GetArr();

        //Console.WriteLine(_Service.MultiplyArryItems(result));

        //Console.WriteLine(_Service.MultiplyArryItems(GetArr()));



        //}

        public void SquareOfSumArrayItems() => Console.WriteLine(_Service.SquareOfSumArrayItems(GetArr()));
        //{

        //int[] arr = { 1, 2, 3, 4, 5, 6, };

        //ICalculateService calculateService = new CalculateService();

        //var result = calculateService.SquareOfSumArrayItems(arr);

        //var result = _Service.SquareOfSumArrayItems(arr);



        //Console.WriteLine(_Service.SquareOfSumArrayItems(arr));

        //var result = GetArr();

        //Console.WriteLine(_Service.SquareOfSumArrayItems(result));

        //Console.WriteLine(_Service.SquareOfSumArrayItems(GetArr()));



        //}

        public int [] GetArr() =>  new []  {1, 2, 3, 4, 5, 6, };
        //{

            //int[] arr = { 1, 2, 3, 4, 5, 6, };

            //return new []  {1, 2, 3, 4, 5, 6, };


        //}


    }
}
