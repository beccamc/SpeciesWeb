# Species Web

A platform for researchers & scientists filled with data & statistics on the worlds biodiversity.

## Development

Species Web was scaffoled using the [Cookiecutter Django template](https://github.com/pydanny/cookiecutter-django)

Run Species Web locally:

```sh
docker compose -f local.yml up
```

Then go to <http://127.0.0.1:8000/> in your browser.

## Technologies

Here is the tech stack used to help create Species Web

- [Docker](https://www.docker.com/)
- [Django](https://www.djangoproject.com/)
- [Python](https://www.python.org/)

### Python libraries

Here are the various Python libraries used for SpeciesWeb:

### Local Scripts

Useful scripts

Run Python type checks:

```sh
mypy speciesweb
```

Run tests, check test coverage, and generate an HTML report:

```sh
coverage run -m pytest
coverage html
open htmlcov/index.html
```
