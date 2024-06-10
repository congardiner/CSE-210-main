using System;


public class Mindfulness
{
    // all attributes that will be handled for inheritance // 

    protected string _title;
    protected string _time;
    // _time will be put in DateTime;
    protected int _countDown;
    protected string _startUpMsg;
    protected string _endActivity;
    protected string _activityDesc;

    // constructor time! //

    public Mindfulness(string title, string time, int countdown, string endactivity, string activitydescription)
    {
        _title = title;
        _time = time;
        _countDown = countdown;
        _endActivity = endactivity;
        _activityDesc = activitydescription;
    }

    public string GetActivityDescription()
    {
        
    }



    






}