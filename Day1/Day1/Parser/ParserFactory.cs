

using Day1.Parser;

namespace Day1.ParserFactory{
    public class ParserFactory{
        //ParserFactory to make the Day 1 part 2 easier
        public IStringParser createParser(Type t){
            if(t ==typeof(int)){
                return new IntParser();
            }
            
            else{
                return null;
            }
        }
    }
}