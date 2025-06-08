
-- Veritabanı oluştur
CREATE DATABASE IF NOT EXISTS sehirtanitim DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE sehirtanitim;

-- Users tablosu
CREATE TABLE IF NOT EXISTS Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50),
    Email VARCHAR(100),
    Password VARCHAR(100),
    Role VARCHAR(20)
);

INSERT INTO Users (Username, Email, Password, Role) VALUES 
('admin', 'admin@eskisehir.com', 'admin123', 'Admin'),
('kullanici', 'kullanici@eskisehir.com', '1234', 'User');

-- Slider tablosu
CREATE TABLE IF NOT EXISTS SliderImages (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    ImageUrl VARCHAR(255)
);

INSERT INTO SliderImages (ImageUrl) VALUES 
('https://example.com/eskisehir1.jpg'),
('https://example.com/eskisehir2.jpg'),
('https://example.com/eskisehir3.jpg');

-- Population tablosu
CREATE TABLE IF NOT EXISTS Population (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Year INT,
    PopulationCount INT
);

INSERT INTO Population (Year, PopulationCount) VALUES 
(2021, 887475),
(2022, 891120),
(2023, 896123);

-- Districts tablosu
CREATE TABLE IF NOT EXISTS Districts (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100)
);

INSERT INTO Districts (Name) VALUES 
('Odunpazarı'),
('Tepebaşı'),
('Sivrihisar'),
('Alpu'),
('İnönü'),
('Mihalıççık');

-- TouristPlaces tablosu
CREATE TABLE IF NOT EXISTS TouristPlaces (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Description TEXT,
    ImageUrl VARCHAR(255)
);

INSERT INTO TouristPlaces (Name, Description, ImageUrl) VALUES
('Odunpazarı Evleri', 'Tarihi evlerin bulunduğu nostaljik bölge.', 'https://example.com/odunpazari.jpg'),
('Sazova Parkı', 'Masal şatosu ve bilim merkezi ile ünlü büyük park.', 'https://example.com/sazova.jpg'),
('Porsuk Çayı', 'Tekne turları ile bilinen şehir içinden geçen nehir.', 'https://example.com/porsuk.jpg'),
('Lületaşı Müzesi', 'Dünyaca ünlü lületaşı ürünlerinin sergilendiği müze.', 'https://example.com/lule.jpg'),
('Kurşunlu Külliyesi', 'Osmanlı döneminden kalma tarihi yapı.', 'https://example.com/kursunlu.jpg'),
('Yılmaz Büyükerşen Balmumu Heykeller Müzesi', 'Ünlü isimlerin balmumu heykellerinin bulunduğu müze.', 'https://example.com/heykel.jpg');
