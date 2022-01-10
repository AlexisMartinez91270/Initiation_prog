let n = 1;
n = prompt("Saisir un nombre positif et inférieur à 100");
do {
  if (n <= 0) {
    n = prompt("SVP positif");
  } else if (n >= 100) {
    n = prompt("SVP inférieur à 100 ");
  }
} while ((n < 0) | (n > 100));
alert("merci pour le nombre " + n);
