package com.k21cnt2.nts.lesson10.repository;
import com.k21cnt2.nts.lesson10.entity.Employee;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
@Repository
public interface EmployeeRepository extends JpaRepository<Employee, Long>{
}