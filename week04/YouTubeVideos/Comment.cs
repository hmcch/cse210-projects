public class Comment
{
    //Public so other classes can access them
    public string Name { get; set; }//Stores the author of the comment
    public string Text { get; set; }//Stores the content of the comment

    //Constructor to initialize new Comment object
    public Comment(string name, string text)
    {
        //Capitalized Name = class property
        //Lowercase name is parameter passed
        Name = name;
        Text = text;
    }
}