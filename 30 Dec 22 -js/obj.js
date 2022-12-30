const languages = ['malayalam', 'english', 'french', 'tamil'];

languages.forEach((element, index) => console.log(index, element));

// or
// foreach(element){
// console.log(element);   
// }

const person = {
    name: '20',
    age: '30',
    edu: 'bca',
    Experience: [{
            company: 'ABC',
            years: 2
        },
        {
            company: 'DEF',
            years: 4
        }
    ]
};

console.log(person.name);
console.log(person.age);

person.Experience.forEach(element => {
    console.log(element.company);
});

// const mat = [
//     [1, 2],
//     [3, 4]
// ];

// const mat2 = [
//     [3, 4],
//     [7, 8]
// ];
// let sum = 0;
// for( let i = 0; i < mat.length; i++ )
// {
//     for ( let j = 0; j < mat2.length; j++)
//     {
//         sum = mat[i][j] + mat2[i][j];
//     }
// }

// console.log(sum);
// matrix addition program

setTimeout(() => {
    console.log('code worked');
}, 1000);

// setInterval(() => {
//     console.log('worked again');
// },1);

const student = {
    fullName: 'student',
    name: 'student1',
    mark1: 40,
    mark2: 50,
    total: function () {
        const extramark = 50;
        console.log(this.mark1 + this.name + this.mark2 + extramark);
    }
};

student.total();

const copy = Object.assign({}, student);
copy.name = 'rohan';
console.log(copy.name);
console.log(student.name);
// copy from multiple objects

// destructuring of objects

const {
    fullName
} = student;
console.log(fullName);

const keys = Object.values(student); // key or values of the objects
keys.forEach((value) => {
    console.log(value);
});