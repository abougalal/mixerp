CREATE FUNCTION core.get_country_id_by_country_code(national character varying(12))
RETURNS integer
AS
$$
BEGIN
    RETURN
        country_id
    FROM
        core.countries
    WHERE
        country_code = $1;
END
$$
LANGUAGE plpgsql;