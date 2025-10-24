using Week5;

MediaRepository mediaRepository = new MediaRepository();

mediaRepository.Add(new Song(0, "Song1", 4.5f, new Artist(0, "David", "America")));
mediaRepository.Add(new Song(1, "Song2", 2.29f, new Artist(0, "David", "America")));
mediaRepository.Add(new Song(2, "Song3", 3.5f, new Artist(0, "David", "America")));

mediaRepository.Add(new Podcast(4, "Podcast1", 15.14f, new Host(1, "Mike", "Comedy")));
mediaRepository.Add(new Podcast(5, "Podcast2", 25.0f, new Host(2, "Jason", "Drama")));
mediaRepository.Add(new Podcast(6, "Podcast3", 4.59f, new Host(1, "Mike", "Comedy")));

// Unsorted list
foreach (var media in mediaRepository.ListAll())
    media.Play();

Console.WriteLine();

// Sorted by title
mediaRepository.SortByTitle();
foreach (var media in mediaRepository.ListAll())
    media.Play();

Console.WriteLine();

// Sorted by duration
mediaRepository.SortByDuration();
foreach (var media in mediaRepository.ListAll())
    media.Play();