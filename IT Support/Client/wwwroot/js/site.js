// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Tabel Animals
const animals = [
    { name: "Fluffy", species: "cat", class: { name: "mamalia" } },
    { name: "Carlo", species: "dog", class: { name: "vertebrata" } },
    { name: "Nemo", species: "fish", class: { name: "mamalia" } },
    { name: "Hamilton", species: "dog", class: { name: "mamalia" } },
    { name: "Dory", species: "fish", class: { name: "mamalia" } },
    { name: "Ursa", species: "cat", class: { name: "mamalia" } },
    { name: "Taro", species: "cat", class: { name: "vertebrata" } }
];

//Fungsi Filter Species
function filterspecies(value) {
    return value.species == 'cat';
}

//Cetak Fungsi Filter Species
const fileredspecies = animals.filter(filterspecies);
console.log(fileredspecies);

//Manipulasi Data
for (let i in animals) {
    if (animals[i].class.name == "vertebrata") {
        animals[i].class.name = "non - mamalia";
    }
}

//Cetak Tabel Animals
console.log(animals);




