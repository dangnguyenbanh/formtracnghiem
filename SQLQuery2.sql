CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY,
    QuestionText NVARCHAR(MAX)
);

CREATE TABLE Answers (
    AnswerID INT PRIMARY KEY,
    QuestionID INT FOREIGN KEY REFERENCES Questions(QuestionID),
    AnswerText NVARCHAR(MAX),
    IsCorrect BIT
);