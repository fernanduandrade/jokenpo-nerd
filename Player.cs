using Game;

public abstract class Player
{
  public static string? ClassType {get; private set;}
  public Classe Type {get; private set;}
  public virtual bool Fight(Classe instance)
  {
    return true;
  }

  public static Player Create(string value)
  {
    ClassType = value;
    return value switch
    {
      "rock" => new Rock(Classe.Rock),
      "paper" => new Paper(Classe.Paper),
      "scissor" => new Scissor(Classe.Scissor),
      "spok" => new Spok(Classe.Spok),
      "lizard" => new Lizard(Classe.Lizard),
      _ => throw new Exception("operação inválida")
    };
  }
}

public class Rock : Player
{
    public Classe Type {get; private set;}
    public Rock(Classe classe)
    {
      Type = classe;
    }
    public override bool Fight(Classe instance)
    {
      return instance switch{
        Classe.Paper => true,
        Classe.Spok => true,
        Classe.Scissor => false,
        Classe.Lizard => false,
        _ => throw new Exception("Opção inválida")
      };
    }
}

public class Paper : Player
{
    public Classe Type {get; private set;}
    public Paper(Classe classe)
    {
      Type = classe;
    }
    public override bool Fight(Classe instance)
    {
      return instance switch{
        Classe.Scissor => true,
        Classe.Lizard => true,
        Classe.Rock => false,
        Classe.Spok => false,
        _ => throw new Exception("Opção inválida")
      };
    }
}

public class Scissor : Player
{
    public Classe Type {get; private set;}
    public Scissor(Classe classe)
    {
      Type = classe;
    }
    public override bool Fight(Classe instance)
    {
      return instance switch{
        Classe.Spok => true,
        Classe.Rock => true,
        Classe.Lizard => false,
        Classe.Paper => false,
        _ => throw new Exception("Opção inválida")
      };
    }
}

public class Spok : Player
{
    public Classe Type {get; private set;}
    public Spok(Classe classe)
    {
      Type = classe;
    }
    public override bool Fight(Classe instance)
    {
      return instance switch{
        Classe.Lizard => true,
        Classe.Paper => true,
        Classe.Scissor => false,
        Classe.Rock => false,
        _ => throw new Exception("Opção inválida")
      };
    }
}

public class Lizard : Player
{
    public Classe Type {get; private set;}
    public Lizard(Classe classe)
    {
      Type = classe;
    }
    public override bool Fight(Classe instance)
    {
      return instance switch{
        Classe.Scissor => true,
        Classe.Rock => true,
        Classe.Paper => false,
        Classe.Spok => false,
        _ => throw new Exception("Opção inválida")
      };
    }
}