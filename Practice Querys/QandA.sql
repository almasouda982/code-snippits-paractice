

/* The HR department wants a query to display the last name, 
job ID, hire date, and employee ID for each employee, 
with the employee ID appearing first. Provide an alias
STARTDATE for the HIRE_DATE column.
*/
select *
from employees

select *
from departments

select employee_id as ID, last_name as "Last Name", job_id as	"JOB ID", hire_date as "Hire Date" 
from employees e, departments d
where d.manager_id = e.manager_id



/*
 Display the employee name and salary for all employees
 who have a salary greater than or equal 4000 and less than or equal  9000 
 and Sorting Data depanden on Salary Who is Have Max Value.
 */

 select *
 from employees

 select concat(first_name, ' ', last_name) as "Full Name", salary as Salary
 from employees
 where salary >= 4000 and salary <= 9000 
 order by salary desc



/* Display the employee name, department, and salary for all employees 
who have no commission (NULL)
*/

select *
from employees

select *
from departments

select concat(first_name, ' ', last_name) Name, department_name as "Department Name", salary Salary
from employees e, departments d
where (e.manager_id = d.manager_id) and commission_pct is not null

select concat(first_name, ' ', last_name) Name, department_name as "Department Name", salary Salary
from employees e join departments d
on e.manager_id = d.manager_id
where commission_pct is not null

/* Display the last name, job, and salary for all employees 
whose salary is not equal 
to $2,500, $3,500, or $7,000.
*/

select *
from employees

select *
from jobs

select last_name "Last Name", job_title "JOB", salary Salary --not equal to  2500 3000 or 7000
from employees e, jobs j
where e.job_id = j.job_id and salary not in('2500','3500','7000')

select last_name "Last Name", job_title "JOB", salary Salary --not equal to  2500 3000 or 7000
from employees e join jobs j
on e.job_id = j.job_id
where salary not in(2500,3500,7000)



/* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.
*/
select *
from employees

select last_name "Last Name", salary Salary
from employees e
where (last_name like'J%' or last_name like'A%' or last_name like'M%') and salary > 6000
order by salary desc




/* 

a) Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the  street address, 
city, state or province, and country in the output.

b) Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the location ID, street address, 
city, state or province, and country  in the output. 

*/

select department_name "Department Name", street_address "Street Address", city City, state_province as "State", country_name Country
from departments d, locations l, countries c
where l.location_id = d.location_id and c.country_id = l.country_id

select department_name "Department Name", street_address "Street Address", city City, state_province as "State", country_name Country
from departments d join locations l
on d.location_id = l.location_id
join countries c
on c.country_id = l.country_id

select *
from departments

select *
from countries

select *
from locations









/* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name for all employees who work in 
Toronto. 
*/

select last_name, job_name, department_id, department_name


select *
from employees

select *
from jobs

select *
from departments


/* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name for all employees who work in 
Toronto. (use cross join)
*/



/*
Write a query to display the job , maximum salary, minimum salary, total salary, 
average salary , and number of employees for each jobs from the employees table. 
Sort the result by job.
*/



/*
Write a query to display the department_id, department name , maximum salary, minimum salary, total salary, 
average salary (rounded), and number of employees for each department from the employees table. 
Include only departments with department_id greater than 30 and having at least 5 employees. 
Sort the result by department_id.
*/

