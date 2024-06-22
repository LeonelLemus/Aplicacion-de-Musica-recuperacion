CREATE DATABASE musicapp;

USE musicapp;

CREATE TABLE canciones (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(255),
    Artista VARCHAR(255),
    Album VARCHAR(255),
    ImagenURL VARCHAR(255),
    AudioFilePath VARCHAR(255)
);

CREATE TABLE playlistcanciones (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    PlaylistID INT,
    CancionID INT
);

CREATE TABLE playlists (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255),
    UsuarioID INT
);

CREATE TABLE usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    NombreUsuario VARCHAR(255),
    Contrasena VARCHAR(255),
    email VARCHAR(255)
);

INSERT INTO canciones (Titulo, Artista, Album, ImagenURL, AudioFilePath) VALUES
('booker t', 'badb bunny', 'ultimo tour del mundo', 'https://drive.google.com/uc?export=dowload&id=1L0xHdsy9jA0nvtKQNiCYiZjE2NqxY8Yr', 'https://drive.google.com/uc?export=dowload&id=181qX0kEP9abG3WoJFhcJt6Rm3hfErwHu'),
('Back in Black', 'CD/DC', 'Back in Black', 'https://drive.google.com/uc?export=dowload&id=1xD1rHOFbD2mqOSjVTeYumxVIBxRH4qZ3', 'https://drive.google.com/uc?export=dowload&id=1R8VUmmzgHsaK15tA8DT094VD0ehnJ3Mt'),
('Thunderstruck', 'AC/DC', 'The Razors Edge', 'https://drive.google.com/uc?export=dowload&id=1nnZhMDZGCLaSQZbQyOkkM0ilCdQ2Jqce', 'https://drive.google.com/uc?export=dowload&id=1qBbJEAeTjazupttjbukQ8pQyeNH_c88I'),
('Goosebumps', 'Travis Sacott', 'Birds In The Trap Sing McKingth', 'https://drive.google.com/uc?export=dowload&id=12uG8_WqOnxXjBsH5ng9sg1XL7Thr0yqF', 'https://drive.google.com/uc?export=dowload&id=1OSb1drVW54ZFpcEKEZyu3EuPggxe01TW'),
('Natural', 'Imagine Dragons', 'Origins (Dleuxe)', 'https://drive.google.com/uc?export=dowload&id=1BEcxOEF44wpr88eKKI7SOeWMRUgJmt09', 'https://drive.google.com/uc?export=dowload&id=1vJh2aj4IpGrKl6JRyY3dRyaPqTDnI-cD'),
('LA CANCIÓN', 'J Balvin, Bad Bunny', 'OASIS', 'https://drive.google.com/uc?export=dowload&id=1yoLD9uVFzhDWQ13EWL-_ufugp4fAmlOf', 'https://drive.google.com/uc?export=dowload&id=1I9c2nEUHKlm27xuwWmmBNK_EclawwBfG'),
('Annihilate', 'Metro Boomin, Swae Lee, Lil Waye, Offset', 'METRO BOOMIN PRESENTS THE SPIDER-MAN: ACROSS THE SPIDER-VERSE', 'https://drive.google.com/uc?export=dowload&id=1Jc-d_p2CxbJA_CmjsQnV5aDvdjyNlSIq', 'https://drive.google.com/uc?export=dowload&id=1aP8xo5ytJVT0wIrIpn_6xXtCoxcHMOBC'),
('On My Own', 'Jadeen, Kid Cudi', 'ERYS', 'https://drive.google.com/uc?export=dowload&id=1PaEwcrBvxzhIz5nW7nLdF9JbIyTIXn59', 'https://drive.google.com/uc?export=dowload&id=1RUc_NpQ_orMgnvdopDWRhQiljir0bqf1'),
('Peso Pluma: Bzrp Music Session, Vol. 55', 'Peso Pluma, Bizarap', 'Peso Pluma: Bzrpa Music Session, Vol. 55', 'https://drive.google.com/uc?export=dowload&id=17Axk8kDnvYB3vtoqKED51Px_k_xBTpfh', 'https://drive.google.com/uc?export=dowload&id=15fNLSIlZ2HmVsieoFJCI7NfaLvAnHi-F'),
('YO LO SÓÑE', 'SAIKO, Omar Montes', 'SAKURA', 'https://drive.google.com/uc?export=dowload&id=1JDM5jteVKWV8_tOzqhEMu8y0drned4gq', 'https://drive.google.com/uc?export=dowload&id=1p6qEj6n34rA4rWubR6TsMQwDiadEqaag');
