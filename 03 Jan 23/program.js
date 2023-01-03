const student = {
    name : 'gokul',
    age : 18,
    mark1 : 10,
    mark2 :8
};

const details = JSON.stringify(student);
const data = JSON.parse(details, null);
console.log(data);