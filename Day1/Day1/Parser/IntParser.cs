using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Parser
{
    internal class IntParser : IStringParser
    {
        private List<int> _numbers= new List<int>() { 0,1,2,3,4,5,6,7,8,9};
        public int ParseNumberToInt(string s)
        {
            if (s==null || s=="")
            {
                return 0;
            }
            //initiates variables
            int number = 0;
            List<int> index = new List<int>();
            foreach(char c in s){
                //verifies if the char is a number (I wanted to do the verif myself)
                if(IsNum(c)){
                    //if so, it adds the index to my index list
                    index.Add(s.IndexOf(c));
                }
            }
            //sums the last digit as a unit
            number += CharToInt(s[index.Last()]);
            //if there's another digit before in the string, it sums it x10 so:
            //8 and 5 -> (8*10) + 5 = 85
            if(index.Count!=1 || index.Count!=0){
                number+=CharToInt(s[index[0]]) * 10;
            }            
            

            return number;
        }
    

        public bool IsNum(char c)
        {
            //checks if the parameter is a digit
            for(int i=0;i<10;i++){
                if(c.ToString() == i.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        //lasy implementation of a char to int cast
        public int CharToInt(char c){
            if(c=='1'){
                return 1 ;
            }if(c=='2'){
                return 2 ;
            }if(c=='3'){
                return 3 ;
            }
            if(c=='4'){
                return 4 ;
            }if(c=='5'){
                return 5 ;
            }if(c=='6'){
                return 6 ;
            }if(c=='7'){
                return 7 ;
            }if(c=='8'){
                return 8 ;
            }if(c=='9'){
                return 9 ;
            }
            return 0;
        }
    }
}