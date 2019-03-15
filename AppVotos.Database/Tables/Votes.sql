CREATE TABLE Votes
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    CandidateId INT NOT NULL,
    VotingTable INT NOT NULL,
    VotesCount INT NOT NULL
)