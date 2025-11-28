LearningPlatformManager learningPlatform = new LearningPlatformManager();

Course<LearningItem> course1 = new Course<LearningItem>("C# Beginner Course");
Course<LearningItem> course2 = new Course<LearningItem>("Algorithms Advanced");

VideoLesson video1 = new VideoLesson("Intro to C#", DifficultyLevel.Beginner, 30);
VideoLesson video2 = new VideoLesson("OOP in C#", DifficultyLevel.Intermediate, 50);

Quiz quiz1 = new Quiz("C# Basics Quiz", DifficultyLevel.Beginner, 20, 4);
Quiz quiz2 = new Quiz("Algorithms Quiz", DifficultyLevel.Advance, 10, 10);

course1.AddContent(video1);
course1.AddContent(quiz1);

course2.AddContent(video2);
course2.AddContent(quiz2);

learningPlatform.CreateCourse(course1);
learningPlatform.CreateCourse(course2);

learningPlatform.ShowAllCourse();