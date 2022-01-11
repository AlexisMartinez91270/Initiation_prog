let n,
  minNeg = 0,
  maxPos = 0;

do {
  n = parseInt(prompt("Rentrer un nombre / ou rentrer 0 pour arrêter"));
  if (n > 0) {
    if (n > maxPos) {
      maxPos = n;
    }
  } else if (n < 0) {
    if (n < minNeg) {
      minNeg = n;
    }
  }
} while (n != 0);

console.log(minNeg);
console.log(maxPos);
