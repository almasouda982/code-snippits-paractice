select  * 
from employees


select  * 
from departments

select  department_name ,first_name 
from departments d left outer join employees e
on d.manager_id = e.employee_id

select  department_name ,first_name 
from departments d  right outer join employees e
on d.manager_id = e.employee_id
order by  department_name desc



select  department_name ,first_name 
from departments d  full outer join employees e
on d.manager_id = e.employee_id
order by  department_name desc