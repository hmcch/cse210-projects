using System;
//To be able to use Lists
using System.Collections.Generic;

public class Video
{
    //Attributes for video class
    public string Title { get; set; }//Keep track of the title

    public string Author { get; set; }//Keep track of the author

    public int Length { get; set; }//Keep track of time in seconds

    //Private list to hold Comment objects
    private List<Comment> _comments = new List<Comment>();

    //Constructor to initialize new Video object with basic information
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    //Method to append new comment inside the list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Returns total comments amount
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    //Method so the Program.cs can access the list of comments
    //and loop through it(list itself is private)
    public List<Comment> GetComments()
    {
        return _comments;
    }

}