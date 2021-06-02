import TextField from '@material-ui/core/TextField';
import React from 'react';
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      '& > *': {
        margin: theme.spacing(1),
        width: '25ch',
      },
    },
  }),
);

export default function Search() {
  const classes = useStyles();
  return (
    <div id="search">
      <form className={classes.root} noValidate autoComplete="off">
        <TextField id="standard-secondary" label="Standard secondary" color="secondary" />
      </form>
    </div>
  );
}
