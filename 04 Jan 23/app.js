// function longRunningTask(callback) {

//     setTimeout(() => {
//       const name = 'js';
//       callback(name);
//     },5000);
//   }

//   function printf (res) {
//     console.log(res);
//   }

//   longRunningTask(printf);
const tar = document.querySelector('#target');

fetch('https://reqres.in/api/users?page=2').then(res => res.json()).then((data) => {

    // for (let i = 0; i < data.data.length; i++) {
    //     console.log(data.data[i].email);
    // }

    // data.data.forEach(element => {
    //     console.log(element.email);
    // });

    data.data.forEach(element => {
        const row = `<tr>
                <td>${element.id}</td>
                <td>
                <img src=" ${element.avatar}" height="50">
                </td>
                <td>${element.first_name}  ${element.last_name}</td>
                <td>${element.email}</td>
                </tr>`;
                   tar.innerHTML += row;
    });
});