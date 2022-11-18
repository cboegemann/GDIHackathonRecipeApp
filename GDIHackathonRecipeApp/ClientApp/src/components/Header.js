import React, { Component, useState } from "react";
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
} from "reactstrap";
import { NavLink } from "react-router-dom";

function Header(args) {
  const [isOpen, setIsOpen] = useState(false);

  const toggle = () => setIsOpen(!isOpen);

  return (
    <div>
      <Navbar {...args}>
        <NavbarBrand href="/">Logo</NavbarBrand>
        <NavbarToggler onClick={toggle} />
        <Collapse isOpen={isOpen} navbar>
          <Nav className="me-auto" navbar>
            <NavItem>
              <NavLink to="/">Home</NavLink>
            </NavItem>
            <NavItem>
              <NavLink to="about">About</NavLink>
            </NavItem>
            <NavItem>
              <NavLink to='login'>Login</NavLink>
            </NavItem>
            <NavItem>
              <NavLink to="saved-recipes">Saved Recipes</NavLink>
            </NavItem>
            <NavItem>
              <NavLink to="recipes">Recipes</NavLink>
            </NavItem>

            {/* for testing only */}
            <NavItem>
              <NavLink to='detail'>Detail</NavLink>
            </NavItem>
            {/* for testing only */}
          </Nav>
        </Collapse>
      </Navbar>
    </div>
  );
}

export default Header;
