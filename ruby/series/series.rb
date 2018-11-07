class Series
  def initialize(series)
    @series = series
  end

  def slices(i)
    substrings = []
    series = @series

    if i > @series.length
      raise ArgumentError
    end

    until series.length < i
      substrings << series[0..i-1]
      series = series[1..-1]
    end

    substrings

  end
end
