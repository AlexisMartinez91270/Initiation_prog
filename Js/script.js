let Main = function () {
  let n = 4,
    p = 5,
    q = 8;
  console.log("Calcul 1 ----------------------------------");
  faitCalculs(n, p + 2);
  console.log("\nCalcul 2 ----------------------------------");
  faitCalculs(2 * n, q);
};

function faitCalculs(x, y) {
  x = parseInt(x);
  y = parseInt(y);
  console.log(`Somme :  ${x + y}`);
  console.log(`Produit :  ${x * y}`);
}

window.onload = Main();
