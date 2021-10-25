CREATE DATABASE oct13Angular;

CREATE TABLE Candidate(
	Id INT NOT NULL PRIMARY KEY,
	ReferredBy NVARCHAR(100) NOT NULL,
	[Name] NVARCHAR(250) NOT NULL,
	LastEmployer NVARCHAR(100) NOT NULL,
	LastDesignation NVARCHAR(50) NOT NULL,
	Experience INT NOT NULL,
	NoticePeriod NVARCHAR(25) NOT NULL,
	Others NVARCHAR(50) NOT NULL
);

CREATE TABLE Source(
	Id INT NOT NULL PRIMARY KEY,
	SourceName NVARCHAR(50) NOT NULL
);

--MAPPING SOURCE AND CANDIDATE
CREATE TABLE SourceCandidateMapping(
	Id INT NOT NULL PRIMARY KEY,
	SourceId INT FOREIGN KEY REFERENCES Source(Id),
	CandidateId INT FOREIGN KEY REFERENCES Candidate(Id)
);

--created table for candidate health
CREATE TABLE HealthCondition(
	Id INT NOT NULL PRIMARY KEY,
	AnyIllness NVARCHAR(30) NOT NULL,
	AnySurgery NVARCHAR(100) NOT NULL,
	CandidateId INT FOREIGN KEY REFERENCES Candidate(Id)
);

--created table for different round details
CREATE TABLE RoundInformation(
	Id INT NOT NULL PRIMARY KEY,
	RoundName NVARCHAR(150) NOT NULL
);

CREATE TABLE Interviewer(
	Id INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(150) NOT NULL,
	InterviewerSign VARBINARY(MAX) NOT NULL
);

CREATE TABLE CandidateStatus(
	Id INT NOT NULL PRIMARY KEY,
	IsCleared BIT NOT NULL,
	[Status] VARCHAR(10) NOT NULL
);

CREATE TABLE CandidateRoundInformation(
	Id INT NOT NULL PRIMARY KEY,
	RoundId INT FOREIGN KEY REFERENCES RoundInformation(Id),
	CandidateId INT FOREIGN KEY REFERENCES Candidate(Id),
	InterviewDate DATETIME NOT NULL,
	Pros NVARCHAR(250) NOT NULL,
	Cons NVARCHAR(250) NOT NULL,
	InterviewerComment NVARCHAR(250) NOT NULL, 
	InterviewerId INT FOREIGN KEY REFERENCES Interviewer(Id),
	StatusId INT FOREIGN KEY REFERENCES CandidateStatus(Id),
	Document VARBINARY(MAX) NOT NULL,
	Comment TEXT NULL
);

--CREATED TABLES FOR RATING
CREATE TABLE Rating(
	Id INT NOT NULL PRIMARY KEY,
	RatingValue NVARCHAR(25) NOT NULL
);


--self recursive table for technical and soft skill
--yet to be implemented

CREATE TABLE TechnicalSkill(
	Id INT NOT NULL PRIMARY KEY,
	CandidateId INT FOREIGN KEY REFERENCES Candidate(Id),
	Concept INT FOREIGN KEY REFERENCES Rating(Id),
	Technical INT FOREIGN KEY REFERENCES Rating(Id),
	Domain INT FOREIGN KEY REFERENCES Rating(Id),
	SkillSet INT FOREIGN KEY REFERENCES Rating(Id),
	AnalyticalSkill INT FOREIGN KEY REFERENCES Rating(Id),
	ProblemSolving INT FOREIGN KEY REFERENCES Rating(Id),
	FocussedAndAlert INT FOREIGN KEY REFERENCES Rating(Id),
	Other INT FOREIGN KEY REFERENCES Rating(Id),
	OverallRating INT NOT NULL 
);


CREATE TABLE SoftSkill(
	Id INT NOT NULL PRIMARY KEY,
	CandidateId INT FOREIGN KEY REFERENCES Candidate(Id),
	Written INT FOREIGN KEY REFERENCES Rating(Id),
	Verbal INT FOREIGN KEY REFERENCES Rating(Id),
	Aptitude INT FOREIGN KEY REFERENCES Rating(Id),
	Leadership INT FOREIGN KEY REFERENCES Rating(Id),
	Initiative INT FOREIGN KEY REFERENCES Rating(Id),
	WillingnessToLearn INT FOREIGN KEY REFERENCES Rating(Id),
	Attitude INT FOREIGN KEY REFERENCES Rating(Id),
	ListeningSkill INT FOREIGN KEY REFERENCES Rating(Id),
	Other INT FOREIGN KEY REFERENCES Rating(Id),
	OverallRating INT NOT NULL 
);

--table for role and hr
CREATE TABLE [Role](
	Id INT NOT NULL PRIMARY KEY,
	[Role] NVARCHAR(30) NOT NULL
);

--TABLE FOR employe details 
CREATE TABLE EmployeeInformation(
	Id INT NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	MobileNumber VARCHAR(10),
    --CONSTRAINT EmployeeInformation CHECK (MobileNumber like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	[Password] NVARCHAR(100) NOT NULL,
	ConfirmPassword NVARCHAR(100) NOT NULL
);

CREATE TABLE EmployeeRoleMapping(
	Id INT NOT NULL PRIMARY KEY,
	EmployeeId INT NOT NULL FOREIGN KEY REFERENCES EmployeeInformation(Id),
	RoleId INT NOT NULL FOREIGN KEY REFERENCES [Role](Id)
);
