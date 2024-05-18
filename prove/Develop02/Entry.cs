using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Entry
{
   public string _response;
   public string _prompt;
   public DateTime _date;

   public Entry(){
    _prompt = PromptGenerator.GeneratePrompt();
    _date = DateTime.Now; 
   }

   public Entry(string prompt, string response, DateTime date){
    _prompt = prompt;
    _response = response;
    _date = date;
   }


   public string getPrompt()
   {
    return _prompt;    
   }
   public void setResponse(string newResponse){
    _response = newResponse;
   }
   public string getResponse(){
    return _response;
   }
   public DateTime getDate()
   {
    return _date; 
   }
   public void Display()
   {
    Console.Write($"Date: {_date.ToShortDateString()} ");
    Console.WriteLine($"-- Prompt: {_prompt}");
    Console.WriteLine(_response); 

   }
}