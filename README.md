# Species Web

A platform for researchers & scientists filled with data & statistics on the worlds biodiversity.

## Development

Species Web was scaffoled using the [Cookiecutter Django template](https://github.com/pydanny/cookiecutter-django)

Run Species Web locally:

```sh
docker compose -f local.yml up
```

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
