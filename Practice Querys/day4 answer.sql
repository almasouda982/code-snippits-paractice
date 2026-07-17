


/*
Write a query to display the department_id, department name
, maximum salary, minimum salary, total salary, 
average salary (rounded), 
and number of employees for each department from the employees table. 
Include only departments with department_id greater than 30 
and having at least 5 employees. 
Sort the result by department_id.
*/


--- department id (employees or departments), department name (departmlents),max, min , total,
---avg rounded, count employees (employee_id), 

--- include departments with department_id greater than 30

--- and having at least 5 employes

select *
from employees

select *
from departments

select e.department_id "Department ID", department_name "Department Name", max(salary) "Maximum Slary",min(salary) "Minimum Salary",sum(salary) "Total Salary",avg(salary) "Average Salary", count(*) "Number of Employees"
from employees e, departments d
where e.department_id = d.department_id and e.department_id > 30
group by e.department_id, department_name
Having count(*) >= 5
order by e.department_id





