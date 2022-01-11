let n,
  sommeNeg = 0,
  sommePos = 0,
  iNeg = 0,
  iPos = 0,
  moyNeg,
  moyPos;

do {
  n = parseInt(prompt("Rentrer un nombre / ou rentrer 0 pour arrêter"));
  if (n < 0) {
    iNeg++;
    sommeNeg += n;
  } else if (n > 0) {
    iPos++;
    sommePos += n;
  }
} while (n != 0);

moyNeg = sommeNeg / iNeg;
moyPos = sommePos / iPos;

console.log(moyNeg);
console.log(moyPos);
