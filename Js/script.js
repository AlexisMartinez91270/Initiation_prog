let n;
do {
  n = prompt("Saisir un nombre positif et inférieur à 100");
} while ((n < 0) | (n > 100));
alert("merci pour le nombre " + n);
