using System;
using System.Collections.Generic;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models{

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Calendar Calendar { get; set; }
}
}