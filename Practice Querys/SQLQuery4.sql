select *
from employees

select *
from departments

select department_name,first_name
from departments d left join employees e
on d.manager_id = e.employee_id

select department_name,first_name
from departments d right join employees e
on d.manager_id = e.employee_id
order by department_name desc

select department_name,first_name
from departments d full join employees e
on d.manager_id = e.employee_id
order by department_name desc


select department_name,first_name
from departments d , employees e
where d.manager_id = e.employee_id
order by department_name desc


select *
from employees

select department_id, max(salary) as Salary, min(salary) Salary, sum(salary) as "Sum", count(*) as Count, avg(salary) as Average
from employees
where department_id is not null
group by department_id



