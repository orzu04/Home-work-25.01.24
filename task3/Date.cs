





public class Date{
    int _day;
    int _month;
    int _year;
     



     public Date()
     {}
      public Date(int Day, int Month)
      {
        _day = Day;
        _month =Month;

      }
    public Date(int Day, int Month,int Year)
      {
        _day = Day;
        _month =Month;
        _year = Year;
        
      }

     public void  SetDate(int day, int month, int year)
     {
        _day= day;
        _month=month;
        _year=year;
     }
     public int GetDay()
     {
        return _day ;
     }
   public int GetMonth()
   {
    return _month;

   }
   public int GetYear()
   {
    return _year;

   }
   public string ToString()
   {
    return $"{_day}/ {_month}/ {_year} ";
   }

}
