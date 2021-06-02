import React from 'react';
import Search from '../components/Home/Search';
import Title from "../components/Home/Title";
import {Container} from "@material-ui/core";

export default function Home() {
  return (
    <div id="home">
      <Container>
        <Title />
        <Search />
      </Container>
    </div>
  );
}
