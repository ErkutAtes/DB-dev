Select * from animals;
Select * from adoptions Order by adoptiondate; -- Ara Tablo
Select * from animallocations;
Select * from adopters ;
Select * from employees;
Select * from medicalrecords;

Select * from medicalrecords;

Select aa.name , adp.firstname from adoptions ad, adopters adp, animals aa Where aa.animalid = ad.animalid and adp.adopterid = ad.adopterid Order by ad.adoptiondate;

Select
	aa.name,
	aa.species,
	aa.breed,
	aa.arrivaldate,
	aa.status,
	l.location
from animals aa, animallocations l
where aa.animalid = l.animalid