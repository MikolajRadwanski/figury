

using System;

public class Osoba {
	private string imie;
	private string nazwisko;
 private DateTime dataUr;

 public Osoba() {
	 dataUr = DateTime.Today;
	 Console.WriteLine("Powstała właśnie klasa Osoba urodzona: " + dataUr);
 }

public DateTime getDataUr() {
  return this.dataUr;
}
 public string getImie() {
	 return imie;
 }
  public void setImie(string ustawImie) {
	  imie = ustawImie;
 }

 public void setNazwisko(string nazwisko) {
	 this.nazwisko = nazwisko;
 }
  public string getNazwisko() {
	 return this.nazwisko;
 }

}
