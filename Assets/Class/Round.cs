using System;

[System.Serializable]
public class Round
{
    public string name;
    public int timeLimit;
    public int pointCorrectAnswer;
    public Question[] questions;
}
