using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {

        string log = null;

        if (id == null && department == null)
        {
            log = name + " - " + "OWNER";
        }
        else if (id==null)
        {
            log = name + " - " + department.ToUpper();
        }
        
        else if (department==null)
        {
            log = "[" + id.ToString() + "]" + " - " + name + " - " + "OWNER";
        }
       
        else
        {
            log = "[" + id.ToString() + "]" + " - " + name + " - " + department.ToUpper();
        }
        
        return log;
    }
}
