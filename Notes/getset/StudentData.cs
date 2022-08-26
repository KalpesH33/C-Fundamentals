using Sysytem;

Class StudentData 
{
    public String StudentName;
    public int StudentID;
    private String studentDivision;
    
     public StudentData(String aStudentName, int aStudentID,String astudentDivision)
     
     {
        StudentName = aStudentName;
        StudentID = aStudentID;
        StudentDivsion = astudentDivsion;
      }
      
      public String StudentDivison()
      {
        get { return studentDivison}
        set {
          if (value == "A" || value == "B" || value == "AB")
          {
         
            studentDivision = value ;
          }
          else 
          {
            studentDivision = "NA";
          
          }
        
        }
      
      
      }
}
