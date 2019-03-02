﻿const baseUrl = 'http://localhost:50204/';

function populateUsersList(users) {
    var $dropdown = $("#userList");
    $.each(users, function () {
        $dropdown.append($("<option />").val(this.Id).text(this.FullName));
    });
}

function populateUserProjects(projects) {
    var $table = $("#projectList tbody");
    $table.empty();
    $.each(projects, function () {
        $table.append(`
            <tr>
              <th scope="row">${this.ProjectId}</th>
              <td>${this.StartDate}</td>
              <td>${this.TimeToStart}</td>
              <td>${this.EndDate}</td>
              <td>${this.Credits}</td>
              <td>${this.Status}</td>
            </tr>
        `);
    });
}

function getUserProjects(user) {
    let userId = user.value;
    if (userId === 0) {
        $("table#userProjects tbody").empty();
    } else {
        $.ajax({
            url: `${baseUrl}user/${userId}/projects`,
            success: function (projects) {
                populateUserProjects(projects);
            }
        });
    }
}

function getUsers() {
    $.ajax({
        url: baseUrl+'user',
        success: function (users) {
            populateUsersList(users);
        }
    });
}

$(document).ready(function () {
    getUsers();
});

