Write a query to display the job , maximum salary, minimum salary, total salary, 
average salary , and number of employees for each jobs from the employees table. 
Sort the result by job.


select *
from employees

select *
from departments


select *
from jobs

select e.job_id "JOB ID", job_title "JOB Title", max(salary) "Max Salary", min(salary) "Min Salary", sum(salary) "Total salary",avg(salary) "Average", count(*)
from employees e, jobs j
where e.job_id = j.job_id
group by job_title, e.job_id
Having sum(salary) > 30000
order by e.job_id




select e.department_id, d.department_name,  max(salary), min(salary), sum(salary),avg(salary), count(*)
from departments d, employees e
where e.department_id = d.department_id
group by department_name, e.department_id
Having sum(salary) > 30000